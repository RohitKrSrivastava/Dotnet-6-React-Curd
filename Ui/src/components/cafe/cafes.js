import React, { Fragment, useContext, useState } from "react";
import withStyles from "@mui/styles/withStyles";
import { GlobalContext } from "../../context/GlobalState";
import { Link } from "react-router-dom";
import {
  Box,
  Typography,
  TableContainer,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Button,
  IconButton,
  Card,
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
} from "@mui/material";
import { Edit as EditIcon, Delete as DeleteIcon } from "@mui/icons-material";
import CafeListing from "./CafeListing";

const styles = (theme) => ({
  blogContentWrapper: {
    marginLeft: theme.spacing(1),
    marginRight: theme.spacing(1),
    [theme.breakpoints.up("sm")]: {
      marginLeft: theme.spacing(4),
      marginRight: theme.spacing(4),
    },
    maxWidth: 1280,
    width: "100%",
  },
  wrapper: {
    minHeight: "60vh",
  },
  noDecoration: {
    textDecoration: "none !important",
  },
});

function Cafes(props) {
  const { cafes, removeCafe, editCafe } = useContext(GlobalContext);
  const { classes } = props;
  const [deleteCafeId, setDeleteCafeId] = useState(null);
  const [openConfirmationDialog, setOpenConfirmationDialog] = useState(false);

  const handleDelete = (cafeId) => {
    setDeleteCafeId(cafeId);
    setOpenConfirmationDialog(true);
  };

  const handleCloseConfirmationDialog = () => {
    setOpenConfirmationDialog(false);
  };

  const handleConfirmDelete = () => {
    removeCafe(deleteCafeId);
    setOpenConfirmationDialog(false);
  };

  return (
    <Fragment>
      <Box justifyContent="center" margin={2}>
        <CafeListing />
        {cafes.length > 0 ? (
          <TableContainer
            component={Card}
            sx={{
              marginBottom: "10px",
              boxShadow: "0px 2px 4px rgba(0, 0, 0, 0.1)",
            }}
          >
            <Table>
              <TableHead>
                <TableRow>
                  <TableCell>Id</TableCell>
                  <TableCell>Cafe Name</TableCell>
                  <TableCell>Discription</TableCell>
                  <TableCell>Location</TableCell>
                  <TableCell>Logo</TableCell>
                  <TableCell>Actions</TableCell>
                </TableRow>
              </TableHead>
              <TableBody>
                {cafes.map((cafe) => (
                  <TableRow key={cafe.id}>
                    <TableCell>{cafe.id}</TableCell>
                    <TableCell>{cafe.name}</TableCell>
                    <TableCell>{cafe.discription}</TableCell>
                    <TableCell>{cafe.location}</TableCell>
                    <TableCell>{cafe.logo}</TableCell>
                    <TableCell>
                      <Link
                        to={`/Cafes/${cafe.id}`}
                        className={classes.noDecoration}
                      >
                        <Button
                          color="primary"
                          size="small"
                          sx={{ borderRadius: "50%", marginRight: "3px" }}
                        >
                          <EditIcon />
                        </Button>
                      </Link>
                      <IconButton
                        color="primary"
                        size="small"
                        onClick={() => handleDelete(cafe.id)}
                        sx={{ borderRadius: "50%" }}
                      >
                        <DeleteIcon />
                      </IconButton>
                    </TableCell>
                  </TableRow>
                ))}
              </TableBody>
            </Table>
          </TableContainer>
        ) : (
          <Typography
            variant="body1"
            align="center"
            sx={{ backgroundColor: "#f5f5f5", color: "#999", py: "5px" }}
          >
            No data
          </Typography>
        )}
      </Box>

      {/* Confirmation Dialog */}
      <Dialog
        open={openConfirmationDialog}
        onClose={handleCloseConfirmationDialog}
      >
        <DialogTitle>Confirm Delete</DialogTitle>
        <DialogContent>
          <Typography>
            Are you sure you want to delete this cafe?
          </Typography>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCloseConfirmationDialog}>Cancel</Button>
          <Button onClick={handleConfirmDelete} color="error">
            Delete
          </Button>
        </DialogActions>
      </Dialog>
    </Fragment>
  );
}

export default withStyles(styles, { withTheme: true })(Cafes);
