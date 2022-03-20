using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sableye Species to store common natural stats of all Sableyes
	#region SableyeSpecies
	public class SableyeSpecies : PokemonSpecies
	{
#nullable enable
		private static SableyeSpecies? _instance = null;
#nullable restore
        public static SableyeSpecies Instance => _instance ?? (_instance = new SableyeSpecies());

		#region SableyeSpecies Constructor
		public SableyeSpecies() : base(
			302,
			"Sableye",
			Dark.Instance, Ghost.Instance,
			0.5,
			11.0,
			new PokemonStats(
				50, // HPs
				75, 75, // Attack & Defense
				65, 65, // Spacial Attack & Defense
				50 // Speed
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Dig",
				"Toxic",
				"Psychic",
				"Night-Shade",
				"Mimic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Metronome",
				"Dream-Eater",
				"Flash",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Mud-Slap",
				"Foresight",
				"Icy-Wind",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Mean-Look",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pain-Split",
				"Dynamic-Punch",
				"Moonlight",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Fake-Out",
				"Torment",
				"Flatter",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Brick-Break",
				"Knock-Off",
				"Imprison",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Water-Pulse",
				"Gravity",
				"Natural-Gift",
				"Feint",
				"Metal-Burst",
				"Payback",
				"Embargo",
				"Fling",
				"Punishment",
				"Sucker-Punch",
				"Poison-Jab",
				"Dark-Pulse",
				"Power-Gem",
				"Nasty-Plot",
				"Shadow-Claw",
				"Shadow-Sneak",
				"Zen-Headbutt",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Wonder-Room",
				"Telekinesis",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Quash",
				"Retaliate",
				"Snarl",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}