using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Togetic Species to store common natural stats of all Togetics
	#region TogeticSpecies
	public class TogeticSpecies : PokemonSpecies
	{
#nullable enable
		private static TogeticSpecies? _instance = null;
#nullable restore
        public static TogeticSpecies Instance => _instance ?? (_instance = new TogeticSpecies());

		#region TogeticSpecies Constructor
		public TogeticSpecies() : base(
			176,
			"Togetic",
			Fairy.Instance, Flying.Instance,
			0.6,
			3.2,
			new PokemonStats(
				55, // HPs
				40, 85, // Attack & Defense
				80, 105, // Spacial Attack & Defense
				40 // Speed
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
				"Mega-Punch",
				"Fly",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Fire-Blast",
				"Swift",
				"Soft-Boiled",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Heat-Wave",
				"Facade",
				"Focus-Punch",
				"Follow-Me",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Brick-Break",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Air-Cutter",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Magical-Leaf",
				"Shock-Wave",
				"Water-Pulse",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Last-Resort",
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
				"Bestow",
				"Work-Up",
				"Fairy-Wind",
				"Confide",
				"Dazzling-Gleam",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion
}