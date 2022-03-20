using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Trumbeak Species to store common natural stats of all Trumbeaks
	#region TrumbeakSpecies
	public class TrumbeakSpecies : PokemonSpecies
	{
#nullable enable
		private static TrumbeakSpecies? _instance = null;
#nullable restore
        public static TrumbeakSpecies Instance => _instance ?? (_instance = new TrumbeakSpecies());

		#region TrumbeakSpecies Constructor
		public TrumbeakSpecies() : base(
			732,
			"Trumbeak",
			Normal.Instance, Flying.Instance,
			0.6,
			14.8,
			new PokemonStats(
				55, // HPs
				85, 50, // Attack & Defense
				40, 50, // Spacial Attack & Defense
				75 // Speed
			)			
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Swords-Dance",
				"Fly",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Peck",
				"Drill-Peck",
				"Toxic",
				"Screech",
				"Double-Team",
				"Rest",
				"Substitute",
				"Thief",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Brick-Break",
				"Feather-Dance",
				"Hyper-Voice",
				"Bullet-Seed",
				"Aerial-Ace",
				"Rock-Blast",
				"Roost",
				"Pluck",
				"U-Turn",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}