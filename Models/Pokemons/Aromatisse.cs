using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Aromatisse Specie to store common natural stats of every {'abilities': ['healer', 'aroma-veil'], 'base_experience': 162, 'height': 8, 'id': 683, 'moves': ['hyper-beam', 'thunderbolt', 'thunder', 'toxic', 'psychic', 'double-team', 'light-screen', 'reflect', 'dream-eater', 'flash', 'rest', 'substitute', 'snore', 'flail', 'protect', 'sweet-kiss', 'charm', 'swagger', 'attract', 'sleep-talk', 'heal-bell', 'return', 'frustration', 'sweet-scent', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'torment', 'facade', 'helping-hand', 'magic-coat', 'endeavor', 'skill-swap', 'secret-power', 'aromatherapy', 'odor-sleuth', 'covet', 'calm-mind', 'gyro-ball', 'drain-punch', 'energy-ball', 'giga-impact', 'flash-cannon', 'trick-room', 'charge-beam', 'psyshock', 'after-you', 'round', 'echoed-voice', 'heal-pulse', 'disarming-voice', 'draining-kiss', 'misty-terrain', 'fairy-wind', 'moonblast', 'confide', 'aromatic-mist', 'dazzling-gleam'], 'name': 'aromatisse', 'stats': {'hp': 101, 'attack': 72, 'defense': 72, 'special-attack': 99, 'special-defense': 89, 'speed': 29}, 'types': ['fairy'], 'weight': 155, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 140, 'color': 'pink', 'shape': 'humanoid', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['fairy'], 'names': {'ja-Hrkt': 'フレフワン', 'ko': '프레프티르', 'zh-Hant': '芳香精', 'fr': 'Cocotine', 'de': 'Parfinesse', 'es': 'Aromatisse', 'it': 'Aromatisse', 'en': 'Aromatisse', 'ja': 'フレフワン', 'zh-Hans': '芳香精'}, 'genera': {'ja-Hrkt': 'ほうこうポケモン', 'ko': '방향포켓몬', 'zh-Hant': '芳香寶可夢', 'fr': 'Pokémon Parfum', 'de': 'Duft', 'es': 'Pokémon Fragancia', 'it': 'Pokémon Fragranza', 'en': 'Fragrance Pokémon', 'ja': 'ほうこうポケモン', 'zh-Hans': '芳香宝可梦'}}
	public class SpecieAromatisse : PokemonSpecie
	{
#nullable enable
		private static SpecieAromatisse? _instance = null;
#nullable restore
        public static SpecieAromatisse Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieAromatisse();
                }
                return _instance;
            }
        }

		public SpecieAromatisse() : base(
			"Aromatisse",
			101, // HPs
			72, 72, // Attack & Defense
			99, 89, // Special Attack & Defense
			29			
		) {}
	}


	//Aromatisse Pokemon Class
	public class Aromatisse : Pokemon
	{

		public Aromatisse(string nickname, int level)
		: base(
				683,
				SpecieAromatisse.Instance, // Pokemon Specie
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Aromatisse() : base(
			683,
			SpecieAromatisse.Instance, // Pokemon Specie
			Fairy.Instance			
		) {}
	}
}