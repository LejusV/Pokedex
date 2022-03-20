using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Landorus-Incarnate Species to store common natural stats of all Landorus-Incarnates
	#region Landorus-IncarnateSpecies
	public class LandorusIncarnateSpecies : PokemonSpecies
	{
#nullable enable
		private static LandorusIncarnateSpecies? _instance = null;
#nullable restore
        public static LandorusIncarnateSpecies Instance => _instance ?? (_instance = new LandorusIncarnateSpecies());

		#region Landorus-IncarnateSpecies Constructor
		public LandorusIncarnateSpecies() : base(
			645,
			"Landorus-Incarnate",
			Ground.Instance, Flying.Instance,
			1.5,
			68.0,
			new PokemonStats(
				89, // HPs
				125, 90, // Attack & Defense
				115, 80, // Spacial Attack & Defense
				101 // Speed
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
				"Hyper-Beam",
				"Strength",
				"Rock-Throw",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Sludge-Bomb",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Rock-Smash",
				"Facade",
				"Role-Play",
				"Superpower",
				"Brick-Break",
				"Knock-Off",
				"Imprison",
				"Secret-Power",
				"Rock-Tomb",
				"Extrasensory",
				"Block",
				"Bulk-Up",
				"Mud-Shot",
				"Calm-Mind",
				"Gravity",
				"Hammer-Arm",
				"U-Turn",
				"Payback",
				"Fling",
				"Punishment",
				"Rock-Polish",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Smack-Down",
				"Sludge-Wave",
				"Round",
				"Bulldoze",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}