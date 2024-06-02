using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace EventDemo

// Publisher.

// The publisher is the class that :

// Declares the Event: It defines the event using the event keyword.
// Raises the Event: It invokes the event, usually when some condition or state change occurs within the class.
{
    public class Hero
    {
        private int _health;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health 
        { 
            get => this._health;
            set
            {
                this._health = value;

                // Notify subscribers hvilken Hero instance og den nye værdi for _health
                // this is the instance that sends the event, along with the new health value
                this.OnHealthChanged?.Invoke(this, _health);
            }            
        }

        // Declarer an event - Dette er meget som at declarere en delegate
        // sender: The first parameter is of type object and refers to the instance that raised the event.
        // e: The second parameter is of type T (in this case, int), and it contains the event data.
        public event EventHandler<int> OnHealthChanged;
    }
}
