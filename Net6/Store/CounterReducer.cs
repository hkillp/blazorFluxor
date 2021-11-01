using Fluxor;

namespace Net6.Store
{
    public static class CounterReducer
    {
        [ReducerMethod]
        public static CounterState OnAddCounter(CounterState state, AddCounter action)
        {
            return state with
            {
                Count = state.Count + 1
            };
        }
    }
}
