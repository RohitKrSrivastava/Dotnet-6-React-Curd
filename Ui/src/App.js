import React, { Fragment, Suspense, lazy } from "react";
import {
  ThemeProvider,
  StyledEngineProvider,
  CssBaseline,
  Box,
} from "@mui/material";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import theme from "./theme";
import GlobalStyles from "./GlobalStyles";
import Pace from "./shared/components/Pace";
import { GlobalProvider } from "./context/GlobalState";

const Main = lazy(() => import("./components/Main"));

function App() {
  return (
    <BrowserRouter>
      <StyledEngineProvider injectFirst>
        <ThemeProvider theme={theme}>
          <CssBaseline />
          <GlobalStyles />
          <Pace color={theme.palette.primary.light} />
          <Suspense fallback={<Fragment />}>
            <GlobalProvider>
              <Switch>
                <Route>
                  <Box marginTop={8}>
                    <Main />
                  </Box>
                </Route>
              </Switch>
            </GlobalProvider>
          </Suspense>
        </ThemeProvider>
      </StyledEngineProvider>
    </BrowserRouter>
  );
}

export default App;
