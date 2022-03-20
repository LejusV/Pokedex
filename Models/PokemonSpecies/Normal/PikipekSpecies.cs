using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pikipek Species to store common natural stats of all Pikipeks
	#region PikipekSpecies
	public class PikipekSpecies : PokemonSpecies
	{
#nullable enable
		private static PikipekSpecies? _instance = null;
#nullable restore
        public static PikipekSpecies Instance => _instance ?? (_instance = new PikipekSpecies());

		#region PikipekSpecies Constructor
		public PikipekSpecies() : base(
			731,
			"Pikipek",
			Normal.Instance, Flying.Instance,
			0.3,
			1.2,
			new PokemonStats(
				35, // HPs
				75, 30, // Attack & Defense
				30, 30, // Spacial Attack & Defense
				65 // Speed
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
				"Mirror-Move",
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
				"Uproar",
				"Brick-Break",
				"Feather-Dance",
				"Hyper-Voice",
				"Bullet-Seed",
				"Aerial-Ace",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Brave-Bird",
				"Smack-Down",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Work-Up",
				"Boomburst",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}