using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Charizard Species to store common natural stats of all Charizards
	#region CharizardSpecies
	public class CharizardSpecies : PokemonSpecies
	{
#nullable enable
		private static CharizardSpecies? _instance = null;
#nullable restore
        public static CharizardSpecies Instance => _instance ?? (_instance = new CharizardSpecies());

		#region CharizardSpecies Constructor
		public CharizardSpecies() : base(
			6,
			"Charizard",
			Fire.Instance, Flying.Instance,
			1.7,
			90.5,
			new PokemonStats(
				78, // HPs
				84, 78, // Attack & Defense
				109, 85, // Spacial Attack & Defense
				100 // Speed
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
				"Scratch",
				"Swords-Dance",
				"Cut",
				"Wing-Attack",
				"Fly",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Dragon-Rage",
				"Fire-Spin",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Smokescreen",
				"Defense-Curl",
				"Reflect",
				"Bide",
				"Fire-Blast",
				"Swift",
				"Skull-Bash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Twister",
				"Sunny-Day",
				"Rock-Smash",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Blast-Burn",
				"Air-Cutter",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Roost",
				"Natural-Gift",
				"Tailwind",
				"Fling",
				"Flare-Blitz",
				"Air-Slash",
				"Dragon-Pulse",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Defog",
				"Captivate",
				"Ominous-Wind",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Sky-Drop",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Bulldoze",
				"Dragon-Tail",
				"Work-Up",
				"Confide",
				"Power-Up-Punch",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion
}