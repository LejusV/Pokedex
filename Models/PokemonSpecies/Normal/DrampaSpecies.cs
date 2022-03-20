using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Drampa Species to store common natural stats of all Drampas
	#region DrampaSpecies
	public class DrampaSpecies : PokemonSpecies
	{
#nullable enable
		private static DrampaSpecies? _instance = null;
#nullable restore
        public static DrampaSpecies Instance => _instance ?? (_instance = new DrampaSpecies());

		#region DrampaSpecies Constructor
		public DrampaSpecies() : base(
			780,
			"Drampa",
			Normal.Instance, Dragon.Instance,
			3.0,
			185.0,
			new PokemonStats(
				78, // HPs
				60, 85, // Attack & Defense
				135, 91, // Spacial Attack & Defense
				36 // Speed
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
				"Razor-Wind",
				"Fly",
				"Roar",
				"Flamethrower",
				"Mist",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Solar-Beam",
				"Dragon-Rage",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Toxic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Glare",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Protect",
				"Outrage",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dragon-Breath",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Facade",
				"Nature-Power",
				"Hyper-Voice",
				"Extrasensory",
				"Dragon-Claw",
				"Calm-Mind",
				"Roost",
				"Natural-Gift",
				"Fling",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Focus-Blast",
				"Energy-Ball",
				"Giga-Impact",
				"Shadow-Claw",
				"Draco-Meteor",
				"Grass-Knot",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Hurricane",
				"Snarl",
				"Play-Rough",
				"Play-Nice",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}