using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEDSign
{
    public class Transitions
    {
        public static List<TransitionModel> GetTransitions()
        {
            List<TransitionModel> transitions = new List<TransitionModel>();
            transitions.Add(new TransitionModel { Description = "Auto", Code = "<FA>" });
            transitions.Add(new TransitionModel { Description = "Open", Code = "<FB>" });
            transitions.Add(new TransitionModel { Description = "Cover", Code = "<FC>" });
            transitions.Add(new TransitionModel { Description = "Appear", Code = "<FD>" });
            transitions.Add(new TransitionModel { Description = "Cycling", Code = "<FE>" });
            transitions.Add(new TransitionModel { Description = "Close <--", Code = "<FF>" });
            transitions.Add(new TransitionModel { Description = "Close -->", Code = "<FG>" });
            transitions.Add(new TransitionModel { Description = "Close --><--", Code = "<FH>" });
            transitions.Add(new TransitionModel { Description = "Scroll Up", Code = "<FI>" });
            transitions.Add(new TransitionModel { Description = "Scroll Down", Code = "<FJ>" });
            transitions.Add(new TransitionModel { Description = "Overlap", Code = "<FK>" });
            transitions.Add(new TransitionModel { Description = "Stacking", Code = "<FL>" });
            transitions.Add(new TransitionModel { Description = "Comic1 (PacMan)", Code = "<FM>" });
            transitions.Add(new TransitionModel { Description = "Comic2", Code = "<FN>" });
            transitions.Add(new TransitionModel { Description = "Beep", Code = "<FO>" });
            transitions.Add(new TransitionModel { Description = "Pause", Code = "<FP>" });
            transitions.Add(new TransitionModel { Description = "Sleep", Code = "<FQ>" });
            transitions.Add(new TransitionModel { Description = "Random", Code = "<FR>" });
            transitions.Add(new TransitionModel { Description = "Shift <--", Code = "<FS>" });
            transitions.Add(new TransitionModel { Description = "Time/Date", Code = "<FT>" });
            transitions.Add(new TransitionModel { Description = "Magic", Code = "<FU>" });
            transitions.Add(new TransitionModel { Description = "Thank You", Code = "<FV>" });
            transitions.Add(new TransitionModel { Description = "Welcome", Code = "<FW>" });
            transitions.Add(new TransitionModel { Description = "Speed 1", Code = "<FX>" });
            transitions.Add(new TransitionModel { Description = "Speed 2", Code = "<FY>" });
            transitions.Add(new TransitionModel { Description = "Speed 3", Code = "<FZ>" });

            return transitions;

        }

    }

    public class TransitionModel
    {
        public string Description { get; set; }
        public string Code { get; set; }
    
    }
}
