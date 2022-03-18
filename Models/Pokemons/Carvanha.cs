using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Carvanha Species to store common natural stats of all Carvanhas
	#region SpeciesCarvanha
	public class SpeciesCarvanha : PokemonSpecies
	{
#nullable enable
		private static SpeciesCarvanha? _instance = null;
#nullable restore
        public static SpeciesCarvanha Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCarvanha();
                }
                return _instance;
            }
        }

		#region SpeciesCarvanha Constructor
		public SpeciesCarvanha() : base(
			318,
			"Carvanha",
			0.8,
			20.8,
			45, // HPs
			90, 20, // Attack & Defense
			65, 20, // Special Attack & Defense
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
				"Take-Down",
				"Thrash",
				"Double-Edge",
				"Leer",
				"Bite",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Toxic",
				"Agility",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Swift",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Scary-Face",
				"Mud-Slap",
				"Destiny-Bond",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Crunch",
				"Ancient-Power",
				"Whirlpool",
				"Uproar",
				"Hail",
				"Torment",
				"Facade",
				"Taunt",
				"Secret-Power",
				"Dive",
				"Poison-Fang",
				"Bounce",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Payback",
				"Assurance",
				"Dark-Pulse",
				"Ice-Fang",
				"Zen-Headbutt",
				"Captivate",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Snarl",
				"Confide",
				"Psychic-Fangs"
			};
		}
		#endregion
	}
	#endregion

	//Carvanha PokemonInstance Class
	#region Carvanha
	public class CarvanhaInstance : PokemonInstance
	{
		#region Carvanha Constructors
		/// <summary>
		/// Carvanha Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CarvanhaInstance(string nickname, int level)
		: base(
				SpeciesCarvanha.Instance, // Pokemon Species
				nickname, level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Builder only waiting for a Level
		/// </summary>
		public CarvanhaInstance(int level)
		: base(
				SpeciesCarvanha.Instance, // PokemonInstance Species
				"Carvanha", level,
				Water.Instance, Dark.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Carvanha Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public CarvanhaInstance() : base(
			SpeciesCarvanha.Instance, // PokemonInstance Species
			Water.Instance, Dark.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}