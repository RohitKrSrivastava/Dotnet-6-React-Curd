import React from "react";
import { Link } from "react-router-dom";
import { Box, Typography, Button } from "@mui/material";
import { AddCircle as AddCircleIcon } from "@mui/icons-material";

function CafeListing() {
  return (
    <Box display="flex" alignItems="center">
      <Box flex={1} textAlign="left" px={4} py={2} m={2}>
        <Typography variant="h5" color="textPrimary" fontWeight="bold">
          Cafe Listing
        </Typography>
      </Box>
      <Box flex={1} textAlign="right" px={4} py={2} m={2}>
        <Link to="/cafe/add" style={{ textDecoration: "none" }}>
          <Button
            variant="contained"
            color="success"
            size="medium"
            startIcon={<AddCircleIcon />}
          >
            Add Cafe
          </Button>
        </Link>
      </Box>
    </Box>
  );
}

export default CafeListing;
