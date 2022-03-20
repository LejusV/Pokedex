using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Victini Species to store common natural stats of all Victinis
	#region VictiniSpecies
	public class VictiniSpecies : PokemonSpecies
	{
#nullable enable
		private static VictiniSpecies? _instance = null;
#nullable restore
        public static VictiniSpecies Instance => _instance ?? (_instance = new VictiniSpecies());

		#region VictiniSpecies Constructor
		public VictiniSpecies() : base(
			494,
			"Victini",
			Psychic.Instance, Fire.Instance,
			0.4,
			4.0,
			new PokemonStats(
				100, // HPs
				100, 100, // Attack & Defense
				100, 100, // Spacial Attack & Defense
				100 // Speed
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
				"Fire-Punch",
				"Thunder-Punch",
				"Headbutt",
				"Double-Edge",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Quick-Attack",
				"Double-Team",
				"Light-Screen",
				"Focus-Energy",
				"Fire-Blast",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Reversal",
				"Protect",
				"Endure",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Brick-Break",
				"Skill-Swap",
				"Secret-Power",
				"Overheat",
				"Signal-Beam",
				"Bounce",
				"Shock-Wave",
				"U-Turn",
				"Embargo",
				"Fling",
				"Last-Resort",
				"Flare-Blitz",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Stored-Power",
				"Incinerate",
				"Final-Gambit",
				"Inferno",
				"Work-Up",
				"Wild-Charge",
				"Searing-Shot",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}