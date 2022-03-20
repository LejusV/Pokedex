using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Groudon Species to store common natural stats of all Groudons
	#region GroudonSpecies
	public class GroudonSpecies : PokemonSpecies
	{
#nullable enable
		private static GroudonSpecies? _instance = null;
#nullable restore
        public static GroudonSpecies Instance => _instance ?? (_instance = new GroudonSpecies());

		#region GroudonSpecies Constructor
		public GroudonSpecies() : base(
			383,
			"Groudon",
			Ground.Instance,
			3.5,
			950.0,
			new PokemonStats(
				100, // HPs
				150, 140, // Attack & Defense
				100, 90, // Spacial Attack & Defense
				90 // Speed
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
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Roar",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Fury-Cutter",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Dynamic-Punch",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Brick-Break",
				"Eruption",
				"Secret-Power",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Bulk-Up",
				"Mud-Shot",
				"Shock-Wave",
				"Hammer-Arm",
				"Natural-Gift",
				"Fling",
				"Rock-Polish",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Rock-Climb",
				"Lava-Plume",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Precipice-Blades",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}