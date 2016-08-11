using Android.App;
using Autobot.Droid.Fragments;
using Autobot.Platform;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Autobot.Droid.Platform
{
    public class Prompt
    {
        private Activity context;
        private IList<ISelectable> items;
        private string title;

        private Prompt()
        {
            // Nobody creates me.
        }

        public static Prompt Make(Activity context, string title, List<ISelectable> source)
        {
            var prompt = new Prompt();
            prompt.context = context;
            prompt.items = source;
            prompt.title = title;
            return prompt;
        }

        public Task<ISelectable> ShowAsync()
        {
            var source = new TaskCompletionSource<ISelectable>();
            var dialog = new PromptListDialogFragment();
            dialog.Source = items;
            dialog.Title = title;
            dialog.Click = (item) =>
            {
                source.SetResult(item);
            };
            dialog.Show(context.FragmentManager, "");
            return source.Task;
        }
    }
}