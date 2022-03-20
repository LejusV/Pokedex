using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Infernape Species to store common natural stats of all Infernapes
	#region InfernapeSpecies
	public class InfernapeSpecies : PokemonSpecies
	{
#nullable enable
		private static InfernapeSpecies? _instance = null;
#nullable restore
        public static InfernapeSpecies Instance => _instance ?? (_instance = new InfernapeSpecies());

		#region InfernapeSpecies Constructor
		public InfernapeSpecies() : base(
			392,
			"Infernape",
			Fire.Instance, Fighting.Instance,
			1.2,
			55.0,
			new PokemonStats(
				76, // HPs
				104, 71, // Attack & Defense
				104, 71, // Spacial Attack & Defense
				108 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Fire-Spin",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Mach-Punch",
				"Mud-Slap",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Role-Play",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Blast-Burn",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Bulk-Up",
				"Covet",
				"Calm-Mind",
				"Natural-Gift",
				"Feint",
				"U-Turn",
				"Close-Combat",
				"Fling",
				"Punishment",
				"Flare-Blitz",
				"Poison-Jab",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Gunk-Shot",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Hone-Claws",
				"Flame-Charge",
				"Low-Sweep",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Retaliate",
				"Fire-Pledge",
				"Bulldoze",
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