using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Sigilyph Species to store common natural stats of all Sigilyphs
	#region SigilyphSpecies
	public class SigilyphSpecies : PokemonSpecies
	{
#nullable enable
		private static SigilyphSpecies? _instance = null;
#nullable restore
        public static SigilyphSpecies Instance => _instance ?? (_instance = new SigilyphSpecies());

		#region SigilyphSpecies Constructor
		public SigilyphSpecies() : base(
			561,
			"Sigilyph",
			Psychic.Instance, Flying.Instance,
			1.4,
			14.0,
			new PokemonStats(
				72, // HPs
				58, 80, // Attack & Defense
				103, 80, // Spacial Attack & Defense
				97 // Speed
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
}