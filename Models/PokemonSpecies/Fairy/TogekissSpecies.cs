using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Togekiss Species to store common natural stats of all Togekisss
	#region TogekissSpecies
	public class TogekissSpecies : PokemonSpecies
	{
#nullable enable
		private static TogekissSpecies? _instance = null;
#nullable restore
        public static TogekissSpecies Instance => _instance ?? (_instance = new TogekissSpecies());

		#region TogekissSpecies Constructor
		public TogekissSpecies() : base(
			468,
			"Togekiss",
			Fairy.Instance, Flying.Instance,
			1.5,
			38.0,
			new PokemonStats(
				85, // HPs
				50, 95, // Attack & Defense
				120, 115, // Spacial Attack & Defense
				80 // Speed
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
				"Fly",
				"Headbutt",
				"Flamethrower",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Extreme-Speed",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Magic-Coat",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Pluck",
				"Tailwind",
				"Fling",
				"Last-Resort",
				"Aura-Sphere",
				"Air-Slash",
				"Drain-Punch",
				"Giga-Impact",
				"Zen-Headbutt",
				"Defog",
				"Captivate",
				"Grass-Knot",
				"Ominous-Wind",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}