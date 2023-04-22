import { BrowserRouter, Routes, Route } from "react-router-dom";
import Home from "../pages/Home";
import { useSelector } from "react-redux";

import { PublicRoutes, PrivateRoutes, AuthRouter, AppRouter } from "../router";

export function App() {
  // usa una variable de estado para verificar si el usuario está conectado
  const authenticate = useSelector((state) => state.authenticate);
  // const authenticate = true;
  console.log(authenticate, " routes");
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Home />} />
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
