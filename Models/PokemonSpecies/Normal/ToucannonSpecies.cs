using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Toucannon Species to store common natural stats of all Toucannons
	#region ToucannonSpecies
	public class ToucannonSpecies : PokemonSpecies
	{
#nullable enable
		private static ToucannonSpecies? _instance = null;
#nullable restore
        public static ToucannonSpecies Instance => _instance ?? (_instance = new ToucannonSpecies());

		#region ToucannonSpecies Constructor
		public ToucannonSpecies() : base(
			733,
			"Toucannon",
			Normal.Instance, Flying.Instance,
			1.1,
			26.0,
			new PokemonStats(
				80, // HPs
				120, 75, // Attack & Defense
				75, 75, // Spacial Attack & Defense
				60 // Speed
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
				"Overheat",
				"Bullet-Seed",
				"Aerial-Ace",
				"Rock-Blast",
				"Roost",
				"Pluck",
				"U-Turn",
				"Flash-Cannon",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Confide",
				"Beak-Blast"
			};
		}
		#endregion
	}
	#endregion
}