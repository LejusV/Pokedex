using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aipom Species to store common natural stats of all Aipoms
	#region AipomSpecies
	public class AipomSpecies : PokemonSpecies
	{
#nullable enable
		private static AipomSpecies? _instance = null;
#nullable restore
        public static AipomSpecies Instance => _instance ?? (_instance = new AipomSpecies());

		#region AipomSpecies Constructor
		public AipomSpecies() : base(
			190,
			"Aipom",
			Normal.Instance,
			0.8,
			11.5,
			new PokemonStats(
				55, // HPs
				70, 55, // Attack & Defense
				40, 55, // Spacial Attack & Defense
				85 // Speed
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
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Slam",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
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
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Role-Play",
				"Revenge",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Tickle",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Switcheroo",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Double-Hit",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}