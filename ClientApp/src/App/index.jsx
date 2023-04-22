import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "../pages/Home";
<<<<<<< HEAD
// import { useSelector, useDispatch } from "react-redux";
=======
import { useSelector } from "react-redux";
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00

import { PublicRoutes, PrivateRoutes, AuthRouter, AppRouter } from "../router";

export function App() {
  // usa una variable de estado para verificar si el usuario está conectado
<<<<<<< HEAD
  // const authenticate = useSelector((state) => state.authenticate);
  const authenticate = true;
  console.log(authenticate, " routes");
  return (
    <BrowserRouter>
      
      <Routes >
    
        <Route path="/" element={<Home/>} />
=======
  const authenticate = useSelector((state) => state.authenticate);
  // const authenticate = true;
  console.log(authenticate, " routes");
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
        <Route
          path="/auth/*"
          element={
            <PublicRoutes isLogged={authenticate}>
              <AuthRouter />
            </PublicRoutes>
          }
        />

        <Route
          path="/app/*"
          element={
            <PrivateRoutes isLogged={authenticate}>
              <AppRouter />
            </PrivateRoutes>
          }
        />
      </Routes>
    </BrowserRouter>
  );
}
