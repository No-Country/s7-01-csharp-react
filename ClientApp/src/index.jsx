import React from "react";
import ReactDOM from "react-dom/client";
import "normalize.css";
import "./styles/index.css";
import { App } from "./App";

<<<<<<< HEAD
const root = ReactDOM.createRoot(document.getElementById("root"));

root.render(<App />);
=======
// redux
import { Provider } from "react-redux";
import { store } from "./redux/store";

const root = ReactDOM.createRoot(document.getElementById("root"));

root.render(
  <Provider store={store}>
    <App />
  </Provider>
);
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
