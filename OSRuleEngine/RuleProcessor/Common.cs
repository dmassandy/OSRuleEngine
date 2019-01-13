using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OSRuleEngine.RuleProcessor
{
    class Common
    {

        public static BinaryExpression CreateBinaryExpression(MemberExpression member, ConstantExpression constant, String op)
        {
            BinaryExpression binaryExpression = null;

            switch(op)
            {
                case "=":
                    binaryExpression = Expression.Equal(member, constant);
                    break;
                case "<>":
                    binaryExpression = Expression.NotEqual(member, constant);
                    break;
                case ">":
                    binaryExpression = Expression.GreaterThan(member, constant);
                    break;
                case ">=":
                    binaryExpression = Expression.GreaterThanOrEqual(member, constant);
                    break;
                case "<":
                    binaryExpression = Expression.LessThan(member, constant);
                    break;
                case "<=":
                    binaryExpression = Expression.LessThanOrEqual(member, constant);
                    break;
                default:
                    break;
            }

            return binaryExpression;
        }

        public static void DebugExprTree(String name, Expression tree)
        {
            Console.WriteLine("DebugExprTree - {0}: {1}", name, tree);
        }

    }
}
