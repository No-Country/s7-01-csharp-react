const initialState = {
  authenticate: true,
};

export default function rootReducer(state = initialState, action) {
  switch (action.type) {
    case "@login/authenticate":
      return {
        ...state,
        authenticate: action.payload,
      };

    default:
      return state;
  }
}
