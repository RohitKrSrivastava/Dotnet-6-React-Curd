import { CastForEducationTwoTone } from "@mui/icons-material";
import axios from "axios";

const api_url = process.env.REACT_APP_END_POINT + "/Cafe/";

export const cafeReducer = (state, action) => {
  switch (action.type) {
    case "FETCH_CAFES_SUCCESS":
      return {
        ...state,
        cafes: action.payload,
        error: null,
      };
    case "FETCH_CAFES_FAILURE":
      return {
        ...state,
        cafes: [],
        error: action.payload,
      };
    case "REMOVE_CAFE_SUCCESS":
      return {
        ...state,
        cafes: state.cafes.filter(
          (cafes) => cafe.id !== action.payload
        ),
        error: null,
      };
    case "REMOVE_CAFE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    case "ADD_CAFE_SUCCESS":
      return {
        ...state,
        cafes: [...state.cafes, action.payload],
        error: null,
      };
    case "ADD_CAFE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    case "EDIT_CAFE_SUCCESS":
      const updatedCafe = action.payload;

      const updatedCafes = state.cafes.map((cafe) => {
        if (cafe.id === updatedCafe.id) {
          return updatedEmployee;
        }
        return employee;
      });

      return {
        ...state,
        cafes: updatedCafes,
        error: null,
      };
    case "EDIT_CAFE_FAILURE":
      return {
        ...state,
        error: action.payload,
      };
    default:
      return state;
  }
};

export const fetchCafes = async (dispatch) => {
  const get_URL = api_url + 'allCafeList';

  try {
    const response = await axios.get(
      get_URL
    );
    const cafesData = response.data;

    dispatch({
      type: "FETCH_CAFES_SUCCESS",
      payload: cafesData,
    });
  } catch (error) {
    dispatch({
      type: "FETCH_CAFES_FAILURE",
      payload: error.message,
    });
  }
};

export const removeCafes = async (dispatch, id) => {
  const delete_URL = api_url + `deleteCafe/${id}`;

  try {
    console.log("Record Deleted" + id);

    await axios.delete(
      delete_URL
    );

    dispatch({
      type: "REMOVE_CAFE_SUCCESS",
      payload: id,
    });
  } catch (error) {
    dispatch({
      type: "REMOVE_CAFE_FAILURE",
      payload: error.message,
    });
  }
};

export const addCafe = async (dispatch, cafe) => {
  const add_URL = api_url + 'addCafeDetails';
  try {
    const response = await axios.post(
      add_URL,
      cafe
    );
    const newCafe = cafe;

    dispatch({
      type: "ADD_CAFE_SUCCESS",
      payload: cafe,
    });
  } catch (error) {
    dispatch({
      type: "ADD_CAFE_FAILURE",
      payload: error.message,
    });
  }
};

export const editCafe = async (dispatch, cafe) => {
  const edit_URL = api_url + 'updateCafeDetails';
  try {
    await axios.put(
      edit_URL,
      cafe
    );

    dispatch({
      type: "EDIT_CAFE_SUCCESS",
      payload: employee,
    });
  } catch (error) {
    dispatch({
      type: "EDIT_CAFE_FAILURE",
      payload: error.message,
    });
  }
};
