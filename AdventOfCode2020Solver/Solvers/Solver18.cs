using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using AdventOfCode2020Solver.Internal;
using AdventOfCode2020Solver.Solvers.Library;
using Sprache;

namespace AdventOfCode2020Solver.Solvers
{
    public class Solver18 : AbstractAocSolver
    {
        private List<string> _equations;

        public Solver18(int n) : base(n) { }

        public override void Solve()
        {
            _equations = ProblemData.Get().ToLines(true).ToList();

            SolveOnce(SolvePart1);
            SolveOnce(SolvePart2);
        }

        public override string SolvePart1()
        {
            return _equations
                  .Sum(equation => (long) MyParserNoPrecedence.ParseExpression(equation).Compile()())
                  .ToString();
        }

        public override string SolvePart2()
        {
            return _equations
                   .Sum(equation => (long) MyParserReversePrecedence.ParseExpression(equation).Compile()())
                   .ToString();
        }

        // yanked from https://github.com/yallie/Sprache.Calc/blob/master/Sprache.Calc/SimpleCalculator.cs
        private static class MyParserNoPrecedence
        {
            private static Parser<string> DecimalWithoutLeadingDigits =>
                from dot in Parse.Char('.')
                from fraction in Parse.Number
                select dot + fraction;

            private static Parser<string> DecimalWithLeadingDigits =>
                Parse.Number.Then(n => DecimalWithoutLeadingDigits.XOr(Parse.Return(string.Empty)).Select(f => n + f));

            private static Parser<string> Decimal => DecimalWithLeadingDigits.XOr(DecimalWithoutLeadingDigits);

            private static Parser<Expression> Constant =>
                Decimal.Select(x => Expression.Constant(double.Parse(x, CultureInfo.InvariantCulture))).Named
                    ("Constant");

            private static Parser<ExpressionType> Operator(string op, ExpressionType opType) =>
                Parse.String(op).Token().Return(opType);

            private static Parser<ExpressionType> Add => Operator("+", ExpressionType.AddChecked);

            private static Parser<ExpressionType> Subtract => Operator("-", ExpressionType.SubtractChecked);

            private static Parser<ExpressionType> Multiply => Operator("*", ExpressionType.MultiplyChecked);

            private static Parser<ExpressionType> Divide => Operator("/", ExpressionType.Divide);

            private static Parser<ExpressionType> Modulo => Operator("%", ExpressionType.Modulo);

            private static Parser<ExpressionType> Power => Operator("^", ExpressionType.Power);

            private static Parser<Expression> ExpressionInParentheses =>
                from lparen in Parse.Char('(')
                from expr in Expr
                from rparen in Parse.Char(')')
                select expr;

            private static Parser<Expression> Factor => ExpressionInParentheses.XOr(Constant);

            private static Parser<Expression> NegativeFactor =>
                from sign in Parse.Char('-')
                from factor in Factor
                select Expression.NegateChecked(factor);

            private static Parser<Expression> Operand => (NegativeFactor.XOr(Factor)).Token();

            private static Parser<Expression> InnerTerm =>
                Parse.ChainRightOperator(Power, Operand, Expression.MakeBinary);

            private static Parser<Expression> Term =>
                Parse.ChainOperator(Multiply.Or(Add).Or(Modulo), InnerTerm, Expression.MakeBinary);

            private static Parser<Expression> Expr =>
                Parse.ChainOperator(Multiply.Or(Add), Term, Expression.MakeBinary);

            private static Parser<LambdaExpression> Lambda =>
                Expr.End().Select(body => Expression.Lambda<Func<double>>(body));

            public static Expression<Func<double>> ParseExpression(string text) =>
                Lambda.Parse(text) as Expression<Func<double>>;
        }

        //yanked from https://github.com/yallie/Sprache.Calc/blob/master/Sprache.Calc/SimpleCalculator.cs
        private static class MyParserReversePrecedence
        {
            private static Parser<string> DecimalWithoutLeadingDigits =>
                from dot in Parse.Char('.')
                from fraction in Parse.Number
                select dot + fraction;

            private static Parser<string> DecimalWithLeadingDigits =>
                Parse.Number.Then(n => DecimalWithoutLeadingDigits.XOr(Parse.Return(string.Empty)).Select(f => n + f));

            private static Parser<string> Decimal => DecimalWithLeadingDigits.XOr(DecimalWithoutLeadingDigits);

            private static Parser<Expression> Constant =>
                Decimal.Select(x => Expression.Constant(double.Parse(x, CultureInfo.InvariantCulture))).Named
                    ("Constant");

            private static Parser<ExpressionType> Operator(string op, ExpressionType opType) =>
                Parse.String(op).Token().Return(opType);

            private static Parser<ExpressionType> Add => Operator("+", ExpressionType.AddChecked);

            private static Parser<ExpressionType> Subtract => Operator("-", ExpressionType.SubtractChecked);

            private static Parser<ExpressionType> Multiply => Operator("*", ExpressionType.MultiplyChecked);

            private static Parser<ExpressionType> Divide => Operator("/", ExpressionType.Divide);

            private static Parser<ExpressionType> Modulo => Operator("%", ExpressionType.Modulo);

            private static Parser<ExpressionType> Power => Operator("^", ExpressionType.Power);

            private static Parser<Expression> ExpressionInParentheses =>
                from lparen in Parse.Char('(')
                from expr in Expr
                from rparen in Parse.Char(')')
                select expr;

            private static Parser<Expression> Factor => ExpressionInParentheses.XOr(Constant);

            private static Parser<Expression> NegativeFactor =>
                from sign in Parse.Char('-')
                from factor in Factor
                select Expression.NegateChecked(factor);

            private static Parser<Expression> Operand => (NegativeFactor.XOr(Factor)).Token();

            private static Parser<Expression> InnerTerm =>
                Parse.ChainRightOperator(Power, Operand, Expression.MakeBinary);

            private static Parser<Expression> Term => Parse.ChainOperator(Add, InnerTerm, Expression.MakeBinary);

            private static Parser<Expression> Expr => Parse.ChainOperator(Multiply, Term, Expression.MakeBinary);

            private static Parser<LambdaExpression> Lambda =>
                Expr.End().Select(body => Expression.Lambda<Func<double>>(body));

            public static Expression<Func<double>> ParseExpression(string text) =>
                Lambda.Parse(text) as Expression<Func<double>>;
        }
    }
}
