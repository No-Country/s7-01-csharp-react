export function authenticateUser(data) {
  return {
    type: "@login/authenticate",
    payload: data,
  };
}
