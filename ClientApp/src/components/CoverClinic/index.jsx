export function CoverClinic() {
  return (
    <div className="container relative mx-auto mt-10">
      <div className="w-full h-48 bg-slate-500 rounded-t-lg">
        <img
          className="w-full h-full object-cover object-center rounded-t-lg"
          src="https://picsum.photos/seed/picsum/500/600"
          alt="cover clinica"
        />
      </div>

      <div>
        <div className="w-28 h-28 rounded-full absolute -bottom-14 ml-4 bg-slate-500">
          <img
            className="w-full h-full rounded-full object-cover object-center"
            src="https://picsum.photos/200/300?random=1"
            alt="perfil"
          />
        </div>
      </div>
    </div>
  );
}
