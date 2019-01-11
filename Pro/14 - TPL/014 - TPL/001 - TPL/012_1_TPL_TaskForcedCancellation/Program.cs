using System;
using System.Linq.Expressions;

namespace _012_1_TPL_TaskForcedCancellation
{
    class Program
    {

        static void Main(string[] args)
        {

            #region MethodInfo

            var consoleWriteLine = typeof (Console).GetMethod("WriteLine", new Type[] {typeof (String)});
            var consoleReadLine = typeof (Console).GetMethod("ReadLine");
            var stringConcat = typeof (String).GetMethod("Concat", new Type[] {typeof (String), typeof (String)});
            var convertToTnt = typeof (Convert).GetMethod("ToInt32", new Type[] {typeof (String)});
            var convertToString = typeof (Convert).GetMethod("ToString", new Type[] {typeof (Int32)});

            #endregion

            #region Constants and Parameters

            var enterA = Expression.Constant("Enter a:");
            var enterB = Expression.Constant("Enter b:");
            var theSumIs = Expression.Constant("The sum of a and b is : ");
            var exceptionMessage = Expression.Constant("Exception: ");

            var parameterA = Expression.Parameter(typeof (Int32), "a");
            var parameterB = Expression.Parameter(typeof (Int32), "b");
            var parameterResult = Expression.Parameter(typeof (Int32), "sum");
            var message = Expression.Parameter(typeof (String), "message");
            var exception = Expression.Parameter(typeof(Exception), "ex");
            

            #endregion

            
            var callReadLine = Expression.Call(consoleReadLine);
            
            var block = Expression.Block(new[] {parameterA, parameterB, parameterResult, message}, 
                
                                         Expression.Call(consoleWriteLine, enterA),
                                         Expression.Assign(parameterA, Expression.Call(convertToTnt,callReadLine)),
                                         Expression.Call(consoleWriteLine, enterB),
                                         Expression.Assign(parameterB, Expression.Call(convertToTnt, callReadLine)),
                
                                         Expression.Assign(parameterResult,Expression.Add(parameterA,parameterB)),
                                         
                                         Expression.Assign(message,Expression.Call(stringConcat,theSumIs,Expression.Call(convertToString,parameterResult))),
                                         Expression.Call(consoleWriteLine,message)
                                         );
           

            //Let's make it safe :)
            var catchBlock = Expression.Catch(exception, 
                Expression.Call(consoleWriteLine, 
                    Expression.Call(stringConcat,exceptionMessage,Expression.Property(exception,"Message"))));
            
            var safeBlock = Expression.TryCatch(block, catchBlock);
            //-----------------------------------------------------
            
            #region Print out the Code!

            Console.WriteLine(safeBlock);
            foreach (var expression in block.Expressions)
            {
                Console.WriteLine("\t"+expression);
            }

            Console.WriteLine(safeBlock.Handlers[0]);
            Console.WriteLine("\t"+safeBlock.Handlers[0].Body);

            #endregion

            Console.WriteLine(new string('-', 40));
            
            Expression<Action> expressionCw = Expression.Lambda<Action>(safeBlock);
            var lambda = expressionCw.Compile();
            
            //Voila!
            lambda();
        }
    }
}
