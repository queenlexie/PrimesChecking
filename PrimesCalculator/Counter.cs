
namespace PrimesCalculator {
    class Counter {
        private int counter;

        public Counter(){
            this.counter = 0;
        }
        public void Increment(){
            this.counter += 1;
        }
        public void Decrement(){
            this.counter -= 1;
        }

        public int GetCounter(){
            return this.counter;
        }
    }
}
