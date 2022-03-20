using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Exploud Species to store common natural stats of all Explouds
	#region ExploudSpecies
	public class ExploudSpecies : PokemonSpecies
	{
#nullable enable
		private static ExploudSpecies? _instance = null;
#nullable restore
        public static ExploudSpecies Instance => _instance ?? (_instance = new ExploudSpecies());

		#region ExploudSpecies Constructor
		public ExploudSpecies() : base(
			295,
			"Exploud",
			Normal.Instance,
			1.5,
			84.0,
			new PokemonStats(
				104, // HPs
				91, 63, // Attack & Defense
				91, 73, // Spacial Attack & Defense
				68 // Speed
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
				"Pound",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Stomp",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Bite",
				"Roar",
				"Supersonic",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Earthquake",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Overheat",
				"Rock-Tomb",
				"Howl",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Focus-Blast",
				"Giga-Impact",
				"Avalanche",
				"Thunder-Fang",
				"Ice-Fang",
				"Fire-Fang",
				"Zen-Headbutt",
				"Rock-Climb",
				"Captivate",
				"Smack-Down",
				"Synchronoise",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Boomburst",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}