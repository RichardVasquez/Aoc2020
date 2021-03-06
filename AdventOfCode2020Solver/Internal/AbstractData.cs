using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2020Solver.Internal
{
    public abstract class AbstractData : IData
    {
        private readonly List<string> Data;
        public string DataText { get; }

        protected AbstractData(List<string> data)
        {
            Data = data;
            string s = Decode();
            DataText = Decode();
        }

        public string Get()
        {
            return DataText;
        }

        private string Decode()
        {
            var result = new MemoryStream();

            if (Data == null || Data.Count == 0)
            {
                return Encoding.ASCII.GetString(result.ToArray());
            }
            
            foreach (string line in Data)
            {
                byte[] encodedBuffer = Encoding.ASCII.GetBytes(line);

                if (encodedBuffer[0] == 0x60)
                {
                    break;
                }

                int nrDecoded = encodedBuffer[0] - 32;

                var decoded = new Byte[nrDecoded];

                for (int i = 1, j = 0;; i += 4)
                {
                    byte[] tmp = encodedBuffer.Skip(i).Take(4).Select(b => (byte) ((b - 0x20) & 0x3F)).ToArray();

                    decoded[j++] = (byte) (tmp[0] << 2 | tmp[1] >> 4);
                    if (j == nrDecoded)
                    {
                        break;
                    }

                    decoded[j++] = (byte) (tmp[1] << 4 | tmp[2] >> 2);
                    if (j == nrDecoded)
                    {
                        break;
                    }

                    decoded[j++] = (byte) (tmp[2] << 6 | tmp[3]);
                    if (j == nrDecoded)
                    {
                        break;
                    }
                }

                result.Write(decoded, 0, nrDecoded);
            }

            return Encoding.ASCII.GetString(result.ToArray());
        }

        public string GetData()
        {
            throw new NotImplementedException();
        }
    }
}
