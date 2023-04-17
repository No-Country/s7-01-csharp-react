export function Radio({ className, label1, label2, label3, onChange, name }) {
  return (
    <div className="flex flex-row gap-5 items-center">
      <div className="flex flex-row">
        <input
          type="radio"
          name={name}
          id={label1}
          defaultChecked={true}
          // onChange={onChange}
          className="h-5 w-5 text-gray-600"
        />
        <label className="ml-2 block text-gray-700" htmlFor={label1}>
          {label1}
        </label>
      </div>
      <div className="flex flex-row">
        <input
          type="radio"
          name={name}
          id={label2}
          // onChange={onChange}
          className="h-5 w-5 text-gray-600"
        />
        <label className="ml-2 block text-gray-700" htmlFor={label2}>
          {label2}
        </label>
      </div>
      <div className="flex flex-row">
        <input
          type="radio"
          name={name}
          id={label3}
          // onChange={onChange}
          className="h-5 w-5 text-gray-600"
        />
        <label className="ml-2 block text-gray-700" htmlFor={label3}>
          {label3}
        </label>
      </div>
    </div>
  );
}
