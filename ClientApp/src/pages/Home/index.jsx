import { useState } from "react";

const Home = () => {
  return (
    <div class="w-full">
      <nav class="mx-auto flex justify-between">
        <div class="text-2xl">
          <img src="" alt="Logo" />
        </div>
        <div class="text-[20px] bg-luis">Hamburguesa</div>
      </nav>
      <div class="mt-6 p-2">
        <h3 class="text-[16px] font-semibold">Mis Mascotas(5)</h3>
      </div>
      <div class="mt-6 flex w-full justify-around md:bg-black">
        <div></div>
        <div class="h-20 w-20 rounded-full border-4 bg-green-500 hover:border-purple-700 hover:scale-125"></div>
        <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
        <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
        <div class="h-20 w-20 rounded-full border bg-green-500 hover:border-purple-700"></div>
      </div>
    </div>
  );
};

export default Home;
