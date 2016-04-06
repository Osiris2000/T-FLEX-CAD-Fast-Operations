using System;
using TFlex.Model;
using TFlex.Model.Model2D;
using TFlex.Model.Model3D;

namespace NewMacroNamespace
{
	public class NewMacroClass
	{
		public static void MadeUnity()//Unite
		{
			Document document = TFlex.Application.ActiveDocument;
            document.BeginChanges("Сложение - быстрая булева");
			
			int i=0;
			Operation mOp1=null;
			Operation mOp2=null;


			BooleanOperation bo = new BooleanOperation(document);
		    BooleanOperation.OperandsArray.Operand op1;
			BooleanOperation.OperandsArray.Operand op2;

			foreach(Operation my_op in document.Selection.GetAllObjects())
			{
					i++;
					
					if(i==1)
					{
						mOp1=my_op;
						op1 = new BooleanOperation.OperandsArray.Operand(mOp1, false);
						bo.FirstOperands.Add(op1);
					}
					if(i>=2)
					{	
						mOp2=my_op;
						op2 = new BooleanOperation.OperandsArray.Operand(mOp2, false);
						bo.SecondOperands.Add(op2);
					}
				    //my_op.Name = my_op.Name+"_123";
			}
			//Булева
		
		    //тип операции - объединение
		    bo.Function = BooleanOperation.FunctionType.Unite;
		    bo.Regenerate(true);

			document.EndChanges();
		}
		
		public static void MadeSubtraction()//Substraction
		{
			Document document = TFlex.Application.ActiveDocument;
            document.BeginChanges("Вычитание - быстрая булева");
			
			int i=0;
			Operation mOp1=null;
			Operation mOp2=null;
			foreach(Operation my_op in document.Selection.GetAllObjects())
			{
					i++;
				    //назначить имя объекту
					//Пока только для двух операндов.
					if(i==1)
						mOp1=my_op;
					if(i>=2)
						mOp2=my_op;
				    //my_op.Name = my_op.Name+"_123";
			}
			//Булева
			BooleanOperation bo = new BooleanOperation(document);

		    BooleanOperation.OperandsArray.Operand op1 = new BooleanOperation.OperandsArray.Operand(mOp1, false);
		    BooleanOperation.OperandsArray.Operand op2 = new BooleanOperation.OperandsArray.Operand(mOp2, false);
		
		    bo.FirstOperands.Add(op1);
		    bo.SecondOperands.Add(op2);
		
		    //тип операции - объединение
		    bo.Function = BooleanOperation.FunctionType.Subtract;
		    bo.Regenerate(true);

			document.EndChanges();
		}

		public static void MadeIntersect()//Intersection
		{
			Document document = TFlex.Application.ActiveDocument;
            document.BeginChanges("Пересечение - быстрая булева");
			
			int i=0;
			Operation mOp1=null;
			Operation mOp2=null;
			foreach(Operation my_op in document.Selection.GetAllObjects())
			{
					i++;
				    //назначить имя объекту
					//Пока только для двух операндов.
					if(i==1)
						mOp1=my_op;
					if(i>=2)
						mOp2=my_op;
				    //my_op.Name = my_op.Name+"_123";
			}
			//Булева
			BooleanOperation bo = new BooleanOperation(document);

		    BooleanOperation.OperandsArray.Operand op1 = new BooleanOperation.OperandsArray.Operand(mOp1, false);
		    BooleanOperation.OperandsArray.Operand op2 = new BooleanOperation.OperandsArray.Operand(mOp2, false);
		
		    bo.FirstOperands.Add(op1);
		    bo.SecondOperands.Add(op2);
		
		    //тип операции - объединение
		    bo.Function = BooleanOperation.FunctionType.Intersect;
		    bo.Regenerate(true);

			document.EndChanges();
		}

		public static void VolumeSeparate()//Volume separation
		{
			Document document = TFlex.Application.ActiveDocument;
            document.BeginChanges("Пересечение - быстрая булева");
			
			int i=0;
			Operation mOp1=null;
			Operation mOp2=null;
			foreach(Operation my_op in document.Selection.GetAllObjects())
			{
					i++;
				    //назначить имя объекту
					//Пока только для двух операндов.
					if(i==1)
						mOp1=my_op;
					if(i==2)
						mOp2=my_op;
				    //my_op.Name = my_op.Name+"_123";
			}

			//--------------------------------------------------
			//Булева
			BooleanOperation bo = new BooleanOperation(document);

		    BooleanOperation.OperandsArray.Operand op1 = new BooleanOperation.OperandsArray.Operand(mOp1, true);
		    BooleanOperation.OperandsArray.Operand op2 = new BooleanOperation.OperandsArray.Operand(mOp2, true);
		
		    bo.FirstOperands.Add(op1);
		    bo.SecondOperands.Add(op2);
		
		    //тип операции - объединение
		    bo.Function = BooleanOperation.FunctionType.Subtract;
		    bo.Regenerate(true);
			//--------------------------------------------------


			//Булева
			bo = new BooleanOperation(document);

		    op1 = new BooleanOperation.OperandsArray.Operand(mOp1, false);
		    op2 = new BooleanOperation.OperandsArray.Operand(mOp2, false);
		
		    bo.FirstOperands.Add(op1);
		    bo.SecondOperands.Add(op2);
		
		    //тип операции - объединение
		    bo.Function = BooleanOperation.FunctionType.Intersect;
		    bo.Regenerate(true);

			document.EndChanges();
		}

	}
}
