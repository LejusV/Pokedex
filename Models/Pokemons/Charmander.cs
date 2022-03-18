using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Charmander Species to store common natural stats of all Charmanders
	#region SpeciesCharmander
	public class SpeciesCharmander : PokemonSpecies
	{
#nullable enable
		private static SpeciesCharmander? _instance = null;
#nullable restore
        public static SpeciesCharmander Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCharmander();
                }
                return _instance;
            }
        }

		#region SpeciesCharmander Constructor
		public SpeciesCharmander() : base(
			4,
			"Charmander",
			0.6,
			8.5,
			39, // HPs
			52, 43, // Attack & Defense
			60, 50, // Special Attack & Defense
			65		
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
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Leer",
				"Bite",
				"Growl",
				"Ember",
				"Flamethrower",
				"Submission",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Dragon-Rage",
				"Fire-Spin",
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
				"Belly-Drum",
				"Mud-Slap",
				"Outrage",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Dragon-Breath",
				"Iron-Tail",
				"Metal-Claw",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Beat-Up",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Brick-Break",
				"Secret-Power",
				"Air-Cutter",
				"Overheat",
				"Rock-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Dragon-Dance",
				"Natural-Gift",
				"Fling",
				"Flare-Blitz",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Shadow-Claw",
				"Fire-Fang",
				"Captivate",
				"Hone-Claws",
				"Flame-Burst",
				"Flame-Charge",
				"Round",
				"Echoed-Voice",
				"Incinerate",
				"Inferno",
				"Fire-Pledge",
				"Work-Up",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Charmander PokemonInstance Class
	#region Charmander
	public class CharmanderInstance : PokemonInstance
	{
		#region Charmander Constructors
		/// <summary>
		/// Charmander Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CharmanderInstance(string nickname, int level)
		: base(
				SpeciesCharmander.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Builder only waiting for a Level
		/// </summary>
		public CharmanderInstance(int level)
		: base(
				SpeciesCharmander.Instance, // PokemonInstance Species
				"Charmander", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Charmander Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CharmanderInstance() : base(
			SpeciesCharmander.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}