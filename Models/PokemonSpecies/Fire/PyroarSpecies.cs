using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Pyroar Species to store common natural stats of all Pyroars
	#region PyroarSpecies
	public class PyroarSpecies : PokemonSpecies
	{
#nullable enable
		private static PyroarSpecies? _instance = null;
#nullable restore
        public static PyroarSpecies Instance => _instance ?? (_instance = new PyroarSpecies());

		#region PyroarSpecies Constructor
		public PyroarSpecies() : base(
			668,
			"Pyroar",
			Fire.Instance, Normal.Instance,
			1.5,
			81.5,
			new PokemonStats(
				86, // HPs
				68, 72, // Attack & Defense
				109, 66, // Spacial Attack & Defense
				106 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Solar-Beam",
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
				"Endeavor",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Bounce",
				"Payback",
				"Dark-Pulse",
				"Giga-Impact",
				"Fire-Fang",
				"Flame-Charge",
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