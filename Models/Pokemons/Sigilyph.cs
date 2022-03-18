using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Sigilyph Species to store common natural stats of all Sigilyphs
	#region SpeciesSigilyph
	public class SpeciesSigilyph : PokemonSpecies
	{
#nullable enable
		private static SpeciesSigilyph? _instance = null;
#nullable restore
        public static SpeciesSigilyph Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesSigilyph();
                }
                return _instance;
            }
        }

		#region SpeciesSigilyph Constructor
		public SpeciesSigilyph() : base(
			561,
			"Sigilyph",
			1.4,
			14.0,
			72, // HPs
			58, 80, // Attack & Defense
			103, 80, // Special Attack & Defense
			97		
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Ice-Beam",
				"Psybeam",
				"Hyper-Beam",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Mirror-Move",
				"Dream-Eater",
				"Sky-Attack",
				"Flash",
				"Psywave",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Heat-Wave",
				"Facade",
				"Trick",
				"Magic-Coat",
				"Skill-Swap",
				"Secret-Power",
				"Air-Cutter",
				"Cosmic-Power",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Shock-Wave",
				"Roost",
				"Gravity",
				"Miracle-Eye",
				"Pluck",
				"Tailwind",
				"Psycho-Shift",
				"Dark-Pulse",
				"Air-Slash",
				"Energy-Ball",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Trick-Room",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Smack-Down",
				"Synchronoise",
				"Round",
				"Stored-Power",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Sigilyph PokemonInstance Class
	#region Sigilyph
	public class SigilyphInstance : PokemonInstance
	{
		#region Sigilyph Constructors
		/// <summary>
		/// Sigilyph Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public SigilyphInstance(string nickname, int level)
		: base(
				SpeciesSigilyph.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Builder only waiting for a Level
		/// </summary>
		public SigilyphInstance(int level)
		: base(
				SpeciesSigilyph.Instance, // PokemonInstance Species
				"Sigilyph", level,
				Psychic.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Sigilyph Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public SigilyphInstance() : base(
			SpeciesSigilyph.Instance, // PokemonInstance Species
			Psychic.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}