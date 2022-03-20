using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Litleo Species to store common natural stats of all Litleos
	#region LitleoSpecies
	public class LitleoSpecies : PokemonSpecies
	{
#nullable enable
		private static LitleoSpecies? _instance = null;
#nullable restore
        public static LitleoSpecies Instance => _instance ?? (_instance = new LitleoSpecies());

		#region LitleoSpecies Constructor
		public LitleoSpecies() : base(
			667,
			"Litleo",
			Fire.Instance, Normal.Instance,
			0.6,
			13.5,
			new PokemonStats(
				62, // HPs
				50, 58, // Attack & Defense
				73, 54, // Spacial Attack & Defense
				72 // Speed
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
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Yawn",
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Payback",
				"Flare-Blitz",
				"Dark-Pulse",
				"Fire-Fang",
				"Flame-Charge",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Wild-Charge",
				"Snarl",
				"Noble-Roar",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}