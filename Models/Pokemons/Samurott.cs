using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Samurott Species to store common natural stats of all Samurotts
	#region SpeciesSamurott
	public class SpeciesSamurott : PokemonSpecies
	{
#nullable enable
		private static SpeciesSamurott? _instance = null;
#nullable restore
        public static SpeciesSamurott Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSamurott();
                }
                return _instance;
            }
        }

		#region SpeciesSamurott Constructor
		public SpeciesSamurott() : base(
			503,
			"Samurott",
			1.5,
			94.6,
			95, // HPs
			100, 85, // Attack & Defense
			108, 70, // Special Attack & Defense
			70		
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
				"Swords-Dance",
				"Cut",
				"Tackle",
				"Tail-Whip",
				"Water-Gun",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Strength",
				"Dig",
				"Toxic",
				"Double-Team",
				"Focus-Energy",
				"Waterfall",
				"Rest",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Rock-Smash",
				"Hail",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Superpower",
				"Revenge",
				"Knock-Off",
				"Secret-Power",
				"Dive",
				"Hydro-Cannon",
				"Aerial-Ace",
				"Block",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Fling",
				"Aqua-Tail",
				"X-Scissor",
				"Giga-Impact",
				"Grass-Knot",
				"Aqua-Jet",
				"Round",
				"Scald",
				"Retaliate",
				"Water-Pledge",
				"Dragon-Tail",
				"Work-Up",
				"Razor-Shell",
				"Confide",
				"Smart-Strike"
			};
		}
		#endregion
	}
	#endregion

	//Samurott PokemonInstance Class
	#region Samurott
	public class SamurottInstance : PokemonInstance
	{
		#region Samurott Constructors
		/// <summary>
		/// Samurott Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SamurottInstance(string nickname, int level)
		: base(
				SpeciesSamurott.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Builder only waiting for a Level
		/// </summary>
		public SamurottInstance(int level)
		: base(
				SpeciesSamurott.Instance, // PokemonInstance Species
				"Samurott", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Samurott Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SamurottInstance() : base(
			SpeciesSamurott.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}