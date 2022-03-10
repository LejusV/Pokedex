using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Charizard Species to store common natural stats of all Charizards
	#region SpeciesCharizard
	public class SpeciesCharizard : PokemonSpecies
	{
#nullable enable
		private static SpeciesCharizard? _instance = null;
#nullable restore
        public static SpeciesCharizard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCharizard();
                }
                return _instance;
            }
        }

		#region SpeciesCharizard Constructor
		public SpeciesCharizard() : base(
			"Charizard",
			1.7,
			90.5,
			78, // HPs
			84, 78, // Attack & Defense
			109, 85, // Special Attack & Defense
			100		
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

	//Charizard PokemonInstance Class
	#region Charizard
	public class CharizardInstance : PokemonInstance
	{
		#region Charizard Constructors
		/// <summary>
		/// Charizard Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CharizardInstance(string nickname, int level)
		: base(
				6,
				SpeciesCharizard.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Builder only waiting for a Level
		/// </summary>
		public CharizardInstance(int level)
		: base(
				6,
				SpeciesCharizard.Instance, // PokemonInstance Species
				"Charizard", level,
				Fire.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charizard Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Charizard() : base(
			6,
			SpeciesCharizard.Instance, // PokemonInstance Species
			Fire.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}