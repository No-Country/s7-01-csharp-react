import { createStore, applyMiddleware, compose } from "redux";
import rootReducer from "../reducers";

// thunk: middleware que hackea el Action creator para retornar una funcion en lugar de una acción, que puede hacer llamadas asincrónicas
import thunk from "redux-thunk";

const composeEnhancers =
  (typeof window !== "undefined" &&
    window.__REDUX_DEVTOOLS_EXTENSION_COMPOSE__) ||
  compose;

export const store = createStore(
  rootReducer,
  composeEnhancers(applyMiddleware(thunk))
);
