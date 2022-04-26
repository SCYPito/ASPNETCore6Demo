using Microsoft.AspNetCore.Components.Forms;

namespace BlazorWasmNet6Exercise
{
    public class CustomFieldClassProvider: FieldCssClassProvider
    {
        public override string GetFieldCssClass(EditContext editContext,
                in FieldIdentifier fieldIdentifier) 
        {
            var isValid =!editContext.GetValidationMessages(fieldIdentifier).Any();

            return isValid ? "text-primary" : "text-danger";
            //修改驗證機制預設的CSS樣式
        }

    }
}
