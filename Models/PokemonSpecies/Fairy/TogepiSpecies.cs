using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Togepi Species to store common natural stats of all Togepis
	#region TogepiSpecies
	public class TogepiSpecies : PokemonSpecies
	{
#nullable enable
		private static TogepiSpecies? _instance = null;
#nullable restore
        public static TogepiSpecies Instance => _instance ?? (_instance = new TogepiSpecies());

		#region TogepiSpecies Constructor
		public TogepiSpecies() : base(
			175,
			"Togepi",
			Fairy.Instance,
			0.3,
			1.5,
			new PokemonStats(
				35, // HPs
				20, 65, // Attack & Defense
				40, 65, // Spacial Attack & Defense
				20 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Peck",
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
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Foresight",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Follow-Me",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Extrasensory",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Psycho-Shift",
				"Lucky-Chant",
				"Last-Resort",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Incinerate",
				"Bestow",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}