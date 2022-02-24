using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Phantump Specie to store common natural stats of every {'abilities': ['natural-cure', 'frisk', 'harvest'], 'base_experience': 62, 'height': 4, 'id': 708, 'moves': ['cut', 'tackle', 'strength', 'leech-seed', 'growth', 'solar-beam', 'dig', 'toxic', 'psychic', 'double-team', 'confuse-ray', 'reflect', 'dream-eater', 'rest', 'rock-slide', 'substitute', 'thief', 'snore', 'curse', 'spite', 'protect', 'feint-attack', 'destiny-bond', 'giga-drain', 'swagger', 'attract', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pain-split', 'hidden-power', 'sunny-day', 'shadow-ball', 'rock-smash', 'will-o-wisp', 'facade', 'nature-power', 'trick', 'role-play', 'ingrain', 'magic-coat', 'skill-swap', 'imprison', 'grudge', 'secret-power', 'astonish', 'worry-seed', 'poison-jab', 'dark-pulse', 'seed-bomb', 'energy-ball', 'shadow-claw', 'trick-room', 'grass-knot', 'wood-hammer', 'foul-play', 'round', 'bestow', 'bulldoze', 'horn-leech', 'phantom-force', 'forests-curse', 'confide', 'venom-drench', 'power-up-punch'], 'name': 'phantump', 'stats': {'hp': 43, 'attack': 70, 'defense': 48, 'special-attack': 50, 'special-defense': 60, 'speed': 38}, 'types': ['ghost', 'grass'], 'weight': 70, 'is_baby': False, 'is_legendary': False, 'is_mythical': False, 'hatch_counter': 20, 'gender_rate': 4, 'capture_rate': 120, 'color': 'brown', 'shape': 'arms', 'habitat': None, 'generation': 'generation-vi', 'growth_rate': 'medium', 'egg_groups': ['plant', 'indeterminate'], 'names': {'ja-Hrkt': 'ボクレー', 'ko': '나목령', 'zh-Hant': '小木靈', 'fr': 'Brocélôme', 'de': 'Paragoni', 'es': 'Phantump', 'it': 'Phantump', 'en': 'Phantump', 'ja': 'ボクレー', 'zh-Hans': '小木灵'}, 'genera': {'ja-Hrkt': 'きりかぶポケモン', 'ko': '그루터기포켓몬', 'zh-Hant': '樹樁寶可夢', 'fr': 'Pokémon Souche', 'de': 'Baumstumpf', 'es': 'Pokémon Tocón', 'it': 'Pokémon Ceppo', 'en': 'Stump Pokémon', 'ja': 'きりかぶポケモン', 'zh-Hans': '树桩宝可梦'}}
	public class SpeciePhantump : PokemonSpecie
	{
#nullable enable
		private static SpeciePhantump? _instance = null;
#nullable restore
        public static SpeciePhantump Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePhantump();
                }
                return _instance;
            }
        }

		public SpeciePhantump() : base(
			"Phantump",
			43, // HPs
			70, 48, // Attack & Defense
			50, 60, // Special Attack & Defense
			38			
		) {}
	}


	//Phantump Pokemon Class
	public class Phantump : Pokemon
	{

		public Phantump(string nickname, int level)
		: base(
				708,
				SpeciePhantump.Instance, // Pokemon Specie
				nickname, level,
				Ghost.Instance, Grass.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public Phantump() : base(
			708,
			SpeciePhantump.Instance, // Pokemon Specie
			Ghost.Instance, Grass.Instance			
		) {}
	}
}