using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPITraningLibrary_5_2
{
    public class SelectionsUtils
    {
        
        public static List<Element> PickObjects(ExternalCommandData commandData, string messege = "Выберете элементы") 
        {
            UIApplication uiapp = commandData.Application; 
            UIDocument uidoc = uiapp.ActiveUIDocument; 
            Document doc = uidoc.Document; 

            var selectedObjects = uidoc.Selection.PickObjects(ObjectType.Element, messege); //
            List<Element> elementList = selectedObjects.Select(selectedObject => doc.GetElement(selectedObject)).ToList(); 
            return elementList; 
        }
    }
}
