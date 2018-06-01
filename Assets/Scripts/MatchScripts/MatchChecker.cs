using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MatchChecker {
	
	public static IEnumerator AnimatePotentialMatches(IEnumerable<GameObject> ponentialMatches) {

		for (float i = 1.0f; i >= 0.3f; i -= 0.1f) {
			foreach(var item in ponentialMatches) {
				Color c = item.GetComponent<SpriteRenderer>().color;
				c.a = i;
				item.GetComponent<SpriteRenderer>().color = c;
			}
			yield return new WaitForSeconds(GameVariables.OpacityAnimationDelay);
		}

		for (float i = 0.3f; i <= 1.0f; i += 0.1f) {
			foreach(var item in ponentialMatches) {
				Color c = item.GetComponent<SpriteRenderer>().color;
				c.a = i;
				item.GetComponent<SpriteRenderer>().color = c;
			}
			yield return new WaitForSeconds(GameVariables.OpacityAnimationDelay);
		}
	} // AnimatePontentialMatches

	public static bool AreHorizontalOrVerticalNeighbors(Marble m1, Marble m2) {
		return (m1.Column == m2.Column || m1.Row == m2.Row) && Mathf.Abs(m1.Column - m2.Column) <= 1 && Mathf.Abs(m1.Row - m2.Row) <= 1;
	}

	public static IEnumerable<GameObject> GetPotentialMatches(MarbleArray marbles) {
		List<List<GameObject>> matches = new List<List<GameObject>> ();

		for (int row = 0; row < GameVariables.Rows; row++) {
			for(int column = 0; column < GameVariables.Columns; column++) {
				var matches1 = CheckHorizontal1(row, column, marbles);
				var matches2 = CheckHorizontal2(row, column, marbles);
				var matches3 = CheckHorizontal3(row, column, marbles);
				var matches4 = CheckVertical1(row, column, marbles);
				var matches5 = CheckVertical2(row, column, marbles);
				var matches6 = CheckVertical3(row, column, marbles);

				if(matches1 != null) matches.Add(matches1);
				if(matches2 != null) matches.Add(matches2);
				if(matches3 != null) matches.Add(matches3);
				if(matches4 != null) matches.Add(matches4);
				if(matches5 != null) matches.Add(matches5);
				if(matches6 != null) matches.Add(matches6);

				if(matches.Count >= 3)
					return matches[Random.Range(0, matches.Count - 1)];

				if(row >= GameVariables.Rows / 2 && matches.Count > 0 && matches.Count <= 2)
					return matches[Random.Range(0, matches.Count - 1)];

			}
		}

		return null;
	}

	public static List<GameObject> CheckHorizontal1(int row, int column, MarbleArray marbles) {

		if (column <= GameVariables.Columns - 2) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column + 1].GetComponent<Marble>())) {

				if(row >= 1 && column >= 1) {

					if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row - 1, column - 1].GetComponent<Marble>())) {

						return new List<GameObject> {
							marbles[row, column],
							marbles[row, column + 1],
							marbles[row - 1, column - 1]
						};

		/* example *\
         * * * * *
         * * * * *
         * * * * *
         * @ & * * <-- First One is the starter
         & * * * *
        \* example  */

						if(row <= GameVariables.Rows - 2 && column >= 1) {
							if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column - 1].GetComponent<Marble>())) {

								return new List<GameObject> {
									marbles[row, column],
									marbles[row, column + 1],
									marbles[row + 1, column - 1]
								};
							}
						}

				/* example *\
                 * * * * *
                 * * * * *
                 & * * * *
                 * @ & * * <-- First one is the starter
                 * * * * *
                \* example  */

					}
				}
			}
		}
		return null;
	} // CheckHorizontal1

	public static List<GameObject> CheckHorizontal2(int row, int column, MarbleArray marbles) {

		if(column <= GameVariables.Columns - 3) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column + 1].GetComponent<Marble>())) {
				if(row >= 1 && column <= GameVariables.Columns - 3) {
					if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row - 1, column + 2].GetComponent<Marble>())) {

						return new List<GameObject> {
							marbles[row, column],
							marbles[row, column + 1],
							marbles[row - 1, column + 2]
						};

		/* example *\
         * * * * *
         * * * * *
         * * * * *
         * @ & * * <-- First one is the starter
         * * * & *
        \* example  */

						if(row <= GameVariables.Rows - 2 && column <= GameVariables.Columns - 3) {
							if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column + 2].GetComponent<Marble>())) {

								return new List<GameObject> {
									marbles[row, column],
									marbles[row, column + 1],
									marbles[row + 1, column + 2]
								};

							}
						}

				/* example *\
                 * * * * *
                 * * * * *
                 * * * & *
                 * @ & * * <-- First one is the starter
                 * * * * *
                \* example  */

					}
				}
			}
		}


		return null;
	} // CheckHorizontal2

	public static List<GameObject> CheckHorizontal3(int row, int column, MarbleArray marbles) {

		if (column <= GameVariables.Columns - 4) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column + 1].GetComponent<Marble>())
				&& marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column + 3].GetComponent<Marble>())) {

				return new List<GameObject> {
					marbles[row, column],
					marbles[row, column + 1],
					marbles[row, column + 3]
				};

	/* example *\
      * * * * *  
      * * * * *
      * * * * *
  	  * @ & * & <-- first one is the starter
      * * * * *
    \* example  */

			}
		}

		if(column >= 2 && column <= GameVariables.Columns - 2) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column + 1].GetComponent<Marble>())
				&& marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row, column - 2].GetComponent<Marble>())) {
				return new List<GameObject> {
					marbles[row, column],
					marbles[row, column + 1],
					marbles[row, column - 2]
				};

	/* example *\
      * * * * * 
      * * * * *
      * * * * *
      * & * @ & <-- The middle one is the starter
      * * * * *
    \* example  */

			}
		}

		return null;
	}

	public static List<GameObject> CheckVertical1(int row, int column, MarbleArray marbles) {

		if (row <= GameVariables.Rows - 2) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column].GetComponent<Marble>())) {
				if(column >= 1 && row >= 1) {
					if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row - 1, column - 1].GetComponent<Marble>())) {

						return new List<GameObject> {
							marbles[row, column],
							marbles[row + 1, column],
							marbles[row - 1, column - 1]
						};

		/* example *\
          * * * * *
          * * * * *
          * & * * *
          * @ * * * <-- starter
          & * * * *
        \* example  */


						if(column <= GameVariables.Columns - 2 && row >= 1) {
							if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row - 1, column + 1].GetComponent<Marble>())) {
								return new List<GameObject> {
									marbles[row, column],
									marbles[row + 1, column],
									marbles[row - 1, column + 1]
								};

				/* example *\
                  * * * * *
                  * * * * *
                  * & * * *
                  * @ * * * <-- starter
                  * * & * *
                \* example  */


							}
						}
					}
				}
			}
		}

		return null;
	}

	public static List<GameObject> CheckVertical2(int row, int column, MarbleArray marbles) {

		if (row <= GameVariables.Rows - 3) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column].GetComponent<Marble>())) {
				if(column >= 1) {
					if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 2, column - 1].GetComponent<Marble>())) {

						return new List<GameObject> {
							marbles[row, column],
							marbles[row + 1, column],
							marbles[row + 2, column - 1]
						};

		/* example *\
          * * * * *
          & * * * *
          * & * * *
          * @ * * * <-- starter
          * * * * *
        \* example  */

						if(column <= GameVariables.Columns - 2) {
							if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 2, column + 1].GetComponent<Marble>())) {
								return new List<GameObject> {
									marbles[row, column],
									marbles[row + 1, column],
									marbles[row + 2, column + 1]
								};

				/* example *\
                  * * * * *
                  * * & * *
                  * & * * *
                  * @ * * * <-- starter
                  * * * * *
                \* example  */

							}
						}
					}
				}
			}
		}

		return null;
	}

	public static List<GameObject> CheckVertical3(int row, int column, MarbleArray marbles) {

		if(row <= GameVariables.Rows - 4) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column].GetComponent<Marble>())
				&& marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 3, column].GetComponent<Marble>())) {
				return new List<GameObject> {
					marbles[row, column],
					marbles[row + 1, column],
					marbles[row + 3, column]
				};

		/* example *\
          * & * * *
          * * * * *
          * & * * *
          * @ * * * <--- starter
          * * * * *
        \* example  */

			}
		}

		if(row >= 2 && row <= GameVariables.Rows - 2) {
			if(marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row + 1, column].GetComponent<Marble>())
				&& marbles[row, column].GetComponent<Marble>().IsSameType(marbles[row - 2, column].GetComponent<Marble>())) {
				return new List<GameObject> {
					marbles[row, column],
					marbles[row + 1, column],
					marbles[row - 2, column]
				};

		/* example *\
          * * * * *
          * & * * *
          * @ * * * <-- starter
          * * * * *
          * & * * *
        \* example  */

			}
		}
	
		return null;
	}

} // MatchChecker


















































