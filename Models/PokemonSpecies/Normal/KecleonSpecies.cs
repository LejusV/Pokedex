using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Kecleon Species to store common natural stats of all Kecleons
	#region KecleonSpecies
	public class KecleonSpecies : PokemonSpecies
	{
#nullable enable
		private static KecleonSpecies? _instance = null;
#nullable restore
        public static KecleonSpecies Instance => _instance ?? (_instance = new KecleonSpecies());

		#region KecleonSpecies Constructor
		public KecleonSpecies() : base(
			352,
			"Kecleon",
			Normal.Instance,
			1.0,
			22.0,
			new PokemonStats(
				60, // HPs
				90, 70, // Attack & Defense
				60, 120, // Spacial Attack & Defense
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Bind",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Disable",
				"Flamethrower",
				"Ice-Beam",
				"Blizzard",
				"Psybeam",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Mimic",
				"Screech",
				"Double-Team",
				"Recover",
				"Defense-Curl",
				"Metronome",
				"Lick",
				"Fire-Blast",
				"Swift",
				"Dizzy-Punch",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Facade",
				"Focus-Punch",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Camouflage",
				"Astonish",
				"Rock-Tomb",
				"Aerial-Ace",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Feint",
				"Fling",
				"Last-Resort",
				"Sucker-Punch",
				"Aqua-Tail",
				"Drain-Punch",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Trick-Room",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Hone-Claws",
				"Wonder-Room",
				"Synchronoise",
				"Foul-Play",
				"After-You",
				"Round",
				"Incinerate",
				"Retaliate",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}