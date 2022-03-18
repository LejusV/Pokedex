using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Yveltal Species to store common natural stats of all Yveltals
	#region SpeciesYveltal
	public class SpeciesYveltal : PokemonSpecies
	{
#nullable enable
		private static SpeciesYveltal? _instance = null;
#nullable restore
        public static SpeciesYveltal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesYveltal();
                }
                return _instance;
            }
        }

		#region SpeciesYveltal Constructor
		public SpeciesYveltal() : base(
			717,
			"Yveltal",
			5.8,
			203.0,
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99		
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
				"Razor-Wind",
				"Cut",
				"Fly",
				"Disable",
				"Hyper-Beam",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Dream-Eater",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Swagger",
				"Steel-Wing",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Secret-Power",
				"Hyper-Voice",
				"Aerial-Ace",
				"Block",
				"Dragon-Claw",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Air-Slash",
				"Dragon-Rush",
				"Focus-Blast",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Hone-Claws",
				"Foul-Play",
				"Round",
				"Sky-Drop",
				"Acrobatics",
				"Hurricane",
				"Snarl",
				"Phantom-Force",
				"Confide",
				"Oblivion-Wing"
			};
		}
		#endregion
	}
	#endregion

	//Yveltal PokemonInstance Class
	#region Yveltal
	public class YveltalInstance : PokemonInstance
	{
		#region Yveltal Constructors
		/// <summary>
		/// Yveltal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public YveltalInstance(string nickname, int level)
		: base(
				SpeciesYveltal.Instance, // Pokemon Species
				nickname, level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Builder only waiting for a Level
		/// </summary>
		public YveltalInstance(int level)
		: base(
				SpeciesYveltal.Instance, // PokemonInstance Species
				"Yveltal", level,
				Dark.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Yveltal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public YveltalInstance() : base(
			SpeciesYveltal.Instance, // PokemonInstance Species
			Dark.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}