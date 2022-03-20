using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Klefki Species to store common natural stats of all Klefkis
	#region KlefkiSpecies
	public class KlefkiSpecies : PokemonSpecies
	{
#nullable enable
		private static KlefkiSpecies? _instance = null;
#nullable restore
        public static KlefkiSpecies Instance => _instance ?? (_instance = new KlefkiSpecies());

		#region KlefkiSpecies Constructor
		public KlefkiSpecies() : base(
			707,
			"Klefki",
			Steel.Instance, Fairy.Instance,
			0.2,
			3.0,
			new PokemonStats(
				57, // HPs
				80, 91, // Attack & Defense
				80, 87, // Spacial Attack & Defense
				75 // Speed
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
				"Cut",
				"Tackle",
				"Hyper-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Spikes",
				"Lock-On",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Torment",
				"Facade",
				"Magic-Coat",
				"Recycle",
				"Imprison",
				"Secret-Power",
				"Astonish",
				"Metal-Sound",
				"Iron-Defense",
				"Covet",
				"Calm-Mind",
				"Heal-Block",
				"Last-Resort",
				"Magnet-Rise",
				"Switcheroo",
				"Giga-Impact",
				"Mirror-Shot",
				"Flash-Cannon",
				"Psyshock",
				"Magic-Room",
				"Foul-Play",
				"Round",
				"Draining-Kiss",
				"Crafty-Shield",
				"Play-Rough",
				"Fairy-Wind",
				"Fairy-Lock",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion
}