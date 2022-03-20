using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Ambipom Species to store common natural stats of all Ambipoms
	#region AmbipomSpecies
	public class AmbipomSpecies : PokemonSpecies
	{
#nullable enable
		private static AmbipomSpecies? _instance = null;
#nullable restore
        public static AmbipomSpecies Instance => _instance ?? (_instance = new AmbipomSpecies());

		#region AmbipomSpecies Constructor
		public AmbipomSpecies() : base(
			424,
			"Ambipom",
			Normal.Instance,
			1.2,
			20.3,
			new PokemonStats(
				75, // HPs
				100, 66, // Attack & Defense
				60, 66, // Spacial Attack & Defense
				115 // Speed
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
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tail-Whip",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Role-Play",
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
				"Giga-Impact",
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
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion
}