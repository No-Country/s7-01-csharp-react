import React from "react";
import { Routes, Route } from "react-router-dom";
// los componentes

export function AuthRouter() {
  return (
    <>
      <Routes>
        <Route path="/login" element={<p> login</p>} />
        <Route path="/register" element={<p> register</p>} />
      </Routes>
    </>
  );
}
