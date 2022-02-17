using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows;


namespace Slats.Helpers
{
    class QuestionTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var question = item as Question;
            FrameworkElement element = container as FrameworkElement;
            if (question == null || element == null) return null;

            string qType = question.Type.ToString();
            DataTemplate template = element.FindResource(qType) as DataTemplate;

            return template;
        }

    }
}
