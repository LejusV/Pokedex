using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Chingling Species to store common natural stats of all Chinglings
	#region ChinglingSpecies
	public class ChinglingSpecies : PokemonSpecies
	{
#nullable enable
		private static ChinglingSpecies? _instance = null;
#nullable restore
        public static ChinglingSpecies Instance => _instance ?? (_instance = new ChinglingSpecies());

		#region ChinglingSpecies Constructor
		public ChinglingSpecies() : base(
			433,
			"Chingling",
			Psychic.Instance,
			0.2,
			0.6,
			new PokemonStats(
				45, // HPs
				30, 50, // Attack & Defense
				65, 50, // Spacial Attack & Defense
				45 // Speed
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
				"Bind",
				"Wrap",
				"Growl",
				"Disable",
				"Thunder-Wave",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Double-Team",
				"Recover",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Icy-Wind",
				"Endure",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Uproar",
				"Torment",
				"Facade",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Recycle",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Astonish",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Shock-Wave",
				"Gravity",
				"Natural-Gift",
				"Last-Resort",
				"Zen-Headbutt",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Entrainment",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}