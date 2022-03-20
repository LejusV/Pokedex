using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Aggron Species to store common natural stats of all Aggrons
	#region AggronSpecies
	public class AggronSpecies : PokemonSpecies
	{
#nullable enable
		private static AggronSpecies? _instance = null;
#nullable restore
        public static AggronSpecies Instance => _instance ?? (_instance = new AggronSpecies());

		#region AggronSpecies Constructor
		public AggronSpecies() : base(
			306,
			"Aggron",
			Steel.Instance, Rock.Instance,
			2.1,
			360.0,
			new PokemonStats(
				70, // HPs
				110, 180, // Attack & Defense
				60, 60, // Spacial Attack & Defense
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
				"Cut",
				"Mega-Kick",
				"Headbutt",
				"Tackle",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Roar",
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
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Earthquake",
				"Dig",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Fire-Blast",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Outrage",
				"Sandstorm",
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
				"Metal-Claw",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Whirlpool",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Superpower",
				"Brick-Break",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Metal-Sound",
				"Aerial-Ace",
				"Iron-Defense",
				"Block",
				"Dragon-Claw",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Metal-Burst",
				"Payback",
				"Fling",
				"Magnet-Rise",
				"Rock-Polish",
				"Dark-Pulse",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Avalanche",
				"Shadow-Claw",
				"Flash-Cannon",
				"Rock-Climb",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Autotomize",
				"Smack-Down",
				"Heavy-Slam",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Confide",
				"Power-Up-Punch",
				"Smart-Strike",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}