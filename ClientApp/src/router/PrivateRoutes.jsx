import { Routes, Route, Navigate } from "react-router-dom";

export function PrivateRoutes({ isLogged, children }) {
  return isLogged ? children : <Navigate to="/auth/login" />;
}
