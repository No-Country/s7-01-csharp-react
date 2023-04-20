const initialState = {
  authenticate: true,
  userId: 9,
  fotoPerfil: "https://iili.io/HV7Uexn.jpg",
  fotoVeterinaria: "https://iili.io/HvkyJ99.jpg",
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
